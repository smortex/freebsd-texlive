# New ports collection makefile for:	texlive-bin-phyzzx
# Date created:		26/01/2009 16:04:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-phyzzx
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A TeX format for physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
