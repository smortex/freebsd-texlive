# $FreeBSD$

PORTNAME=	pdflatexpicscale
PORTVERSION=	20160731
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Support software for downscaling graphics to be included by pdfLaTeX

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
