# $FreeBSD$

PORTNAME=	xindy
PORTVERSION=	20150624
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A general-purpose index processor.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
