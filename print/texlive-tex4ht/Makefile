# $FreeBSD$

PORTNAME=	tex4ht
PORTVERSION=	20160705
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Convert (La)TeX to HTML/XML

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
