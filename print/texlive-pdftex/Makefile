# $FreeBSD$

PORTNAME=	pdftex
PORTVERSION=	20160330
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX extension for direct creation of PDF

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
