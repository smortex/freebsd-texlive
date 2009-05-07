# New ports collection makefile for:	texlive-bin-metapost
# Date created:		26/01/2009 16:03:20
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-metapost
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A development of MetaFont that generates PostScript output.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
