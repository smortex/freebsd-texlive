# $FreeBSD$

PORTNAME=	crossrefware
PORTVERSION=	20150823
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Scripts for working with crossref.org

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
