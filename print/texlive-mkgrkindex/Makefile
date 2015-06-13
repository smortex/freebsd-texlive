# $FreeBSD$

PORTNAME=	mkgrkindex
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Makeindex working with Greek.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
