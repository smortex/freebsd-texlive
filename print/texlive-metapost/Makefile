# $FreeBSD$

PORTNAME=	metapost
PORTVERSION=	20160427
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A development of Metafont for creating graphics

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
