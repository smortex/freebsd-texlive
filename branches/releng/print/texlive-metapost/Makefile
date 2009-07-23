# New ports collection makefile for:	texlive-metapost
# Date created:		26/01/2009 16:03:20
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	metapost
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A development of MetaFont that generates PostScript output.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.metapost.cnf:${PORTSDIR}/print/texlive-bin-metapost

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
